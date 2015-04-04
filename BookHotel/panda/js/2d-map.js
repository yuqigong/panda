var cvs, ctx, cvsParent, cvsParentWidth, cvsParentHeight;
var rows = 40,
    cols = 30,
    unit;

var showPopFn,
    toDetail,
    toDetail2;

var currentScale = 1,
    gesStart = 0,
    gesEnd = 0;

var roomHashMap = [];

var bindEvents = function() {
    window.bullets = document.getElementById('position').getElementsByTagName('em');
    window.mySwipe = new Swipe(document.getElementById('slider'), {
        startSlide: 0,
        continuous: true,
        disableScroll: true,
        stopPropagation: false,
        callback: function(e, pos) {
            var i = bullets.length;
            while (i--) {
                bullets[i].className = ' ';
            }
            bullets[pos].className = 'on';
        }
    });
}

function handle(fn) {
    flag = false;
    showPopFn = fn.showPop;
    toDetail = fn.toDetail;
    toDetail2 = fn.toDetail2;
    x_pop = fn.x_pop;
    unit = document.getElementById("js_header").offsetWidth / rows;
    cvs = document.getElementById("cvs");
    ctx = cvs.getContext("2d");
    cvsParentWidth = unit * rows;
    cvsParentHeight = unit * cols;
    cvs.addEventListener("mousedown", mouseHandle);
    cvs.addEventListener("gesturestart", gesStartHandle);
    cvs.addEventListener("gestureend", gesEndHandle);
    document.getElementById("toDetailBtn").addEventListener("mousedown", toDetail);
    document.getElementById("toDetailBtn2").addEventListener("mousedown", toDetail2);
    $("#choose").change(cho);
    setCvsStyle();
    drawMaps();
    drawRoom(rooms1DATA);
}

function cho(e) {
    var v = this.value;
    switch (v) {
        case "1":
        {
            drawRoom(rooms1DATA);
            break;
        }
        case "2":
        {
            drawRoom(rooms2DATA);
            break;
        }
        case "3":
        {
            drawRoom(rooms3DATA);
            break;
        }
    }
}

function setCvsStyle() {
    cvs.setAttribute('width', rows * unit + 1);
    cvs.setAttribute('height', cols * unit + 1);
}

function addPoint(v) {
    return v + 0.5;
}

function drawMaps() {
    ctx.save();
    ctx.beginPath();
    ctx.strokeStyle = '#e3e3e3';
    ctx.lineWidth = 1;
    for (var i = 0; i <= rows; i++) {
        ctx.moveTo(addPoint(unit * i), addPoint(0));
        ctx.lineTo(addPoint(unit * i), addPoint(unit * cols));
    }
    for (var j = 0; j <= cols; j++) {
        ctx.moveTo(addPoint(0), addPoint(unit * j));
        ctx.lineTo(addPoint(unit * rows), addPoint(unit * j));
    }
    ctx.stroke();
    ctx.closePath();
    ctx.restore();
}

function drawRoom(url) {
    ctx.clearRect(0,0,cvsParentWidth,cvsParentHeight);
    roomHashMap = [];
    roomHashMap.length = 0;
    ctx.save();
    ctx.beginPath();

    var room1 = [],
        room2 = [];

    url.forEach(function (el, i) {
        if (el.RoomTypeId == 3) {
            room1.push(el);
        } else {
            room2.push(el);
        }
    });

    var r3 = room1.concat(room2);

    //$.getJSON(url, function(data) {
        r3.map(function (el, i) {
            var $n = el.RoomTypeId == -1 ? 0 : el.RoomTypeId
            var t = roomType[$n];
            var obj = {
                x: el.PositionX * unit,
                width: addPoint(el.Width * unit),
                y: el.PositionY * unit,
                height: addPoint(el.Height * unit)
            };
            var xpos = obj.width/2;
            var ypos = obj.height/2;
            var radius = el.Angle * Math.PI / 180;
            var img = new Image();
            img.src = el.PicURl;

            img.onload = img.onerror = function(e) {
                ctx.save();
                ctx.translate(xpos+obj.x, ypos+obj.y);
                ctx.rotate(0);
                ctx.translate(-xpos-obj.x, -ypos-obj.y);
                ctx.fillStyle = t.Color;
                if(e.type == "error") {
                    ctx.fillRect(obj.x, obj.y, obj.width, obj.height);
                }else{
                    roomHashMap.push({
                        minX: obj.x,
                        maxX: obj.x + obj.width,
                        minY: obj.y,
                        maxY: obj.y + obj.height,
                        no: el.RoomNo,
                        message: el.Message,
                        name: t.Name,
                        price: t.Price,
                        isCanBook : el.IsCanBook
                    });
                }

                ctx.strokeStyle = "#aaa";
                ctx.translate(xpos+obj.x, ypos+obj.y);
                ctx.rotate( radius );
                ctx.translate( -obj.x-xpos, -obj.y-ypos );
                ctx.drawImage( img,obj.x ,obj.y, obj.width, obj.height );
                ctx.strokeText( el.RoomNo,obj.x+obj.width/2 - 10,obj.y+obj.height/2-3);
                ctx.restore();
            }
        //});
        ctx.closePath();
        ctx.restore();
    })
}

var getCoord = function(e) {
    return {
        x: e.offsetX,
        y: e.offsetY
    }
};

var OBB = function(options, callback) {
    var x = options.x,
        y = options.y;
    roomHashMap.map(function(el) {
        if (x > el.minX && x < el.maxX && y < el.maxY && y > el.minY) {
            return callback(el);
        }
    })
};

function mouseHandle(e) {
    OBB(getCoord(e), function(data) {
        if(data.no == "电梯") return;
        if( !data.isCanBook ){
            alert("该房间已经被预定!");
            return;
        }
        if( data.name == "会议室" ){
            console.log(1);
            x_pop();
        }else{
            showPopFn();
        }

        bindEvents();
    });
}

function getTouchHandle(scaleNNN){
    var se = ((gesEnd - gesStart) / 2.5);
    currentScale += se;
    if(scaleNNN) currentScale = scaleNNN;
    if (currentScale <= 0.5) {
        currentScale = 0.5;
    }
    if (currentScale >= 2) {
        currentScale = 2;
    }
    cvsParent.style.width = cvsParentWidth * currentScale + "px";
    cvsParent.style.height = cvsParentHeight * currentScale + "px";
    cvs.style.cssText = "resize:auto;-webkit-transform-origin:0% 0%;-webkit-transition:all .2s;-webkit-transform:scale(" + currentScale + ")";
}

function gesStartHandle(e) {
    gesStart = e.scale;
}

function gesEndHandle(e) {
    gesEnd = e.scale;
    getTouchHandle();
}
