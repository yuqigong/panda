var cvs,ctx,cvsParent,cvsParentWidth,cvsParentHeight;
var rows = 30,
    cols = 30,
    unit;

var showPopFn,
    toDetail;

var currentScale = 1,
    gesStart,
    gesEnd;

var roomHashMap = [];

var bindEvents = function (){
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
        },
        transitionEnd: function(index, elem) {}
    });
}

function handle (fn){
    flag = false;
    showPopFn = fn.showPop;
    toDetail = fn.toDetail;
    unit = document.getElementById("js_header").offsetWidth / rows;
    cvs = document.getElementById("cvs");
    ctx = cvs.getContext("2d");
    cvsParentWidth = unit * rows;
    cvsParentHeight = unit * cols;
    cvs.addEventListener("mousedown", mouseHandle);
    cvs.addEventListener("gesturestart",gesStartHandle);
    cvs.addEventListener("gestureend", gesEndHandle);
    document.getElementById("toDetailBtn").addEventListener("mousedown", toDetail);
    setCvsStyle();
    drawMaps();
    drawRoom();
}

function setCvsStyle (){
    cvs.setAttribute('width',rows * unit + 1);
    cvs.setAttribute('height',cols * unit +1);
}

function addPoint(v){
    return v + 0.5;
}

function drawMaps (){
    ctx.save();
    ctx.beginPath();
    ctx.strokeStyle = '#e3e3e3';
    ctx.lineWidth = 1;
    for(var i=0;i<=rows;i++){
        ctx.moveTo(addPoint(unit*i),addPoint(0));
        ctx.lineTo(addPoint(unit*i),addPoint(unit*cols));
    }
    for(var j=0;j<=cols;j++){
        ctx.moveTo(addPoint(0),addPoint(unit*j));
        ctx.lineTo(addPoint(unit*rows),addPoint(unit*j));
    }
    ctx.stroke();
    ctx.closePath();
    ctx.restore();
}

function drawRoom(){
    ctx.save();
    ctx.beginPath();
    $.getJSON("../data/rooms.json", function (data){
        data.map(function (el,i){
            var t = roomType[el.RoomTypeId];
            var obj = {
                x : el.PositionX*unit,
                width : addPoint(el.Width*unit),
                y : el.PositionY*unit,
                height : addPoint(el.Height*unit)
            };

            var xpos = obj.width/2;
            var ypos = obj.height/2;
            var radius = 90 * Math.PI / 180;

            var img = new Image();
            img.onload = function (){
                ctx.save();
                ctx.fillStyle = t.Color;
                ctx.strokeStyle = t.Color;
                /*ctx.translate(xpos, ypos);
                ctx.rotate(radius);
                ctx.translate(-xpos, -ypos);*/
                ctx.fillRect( obj.x,obj.y, obj.width, obj.height);
                ctx.drawImage(img,obj.x,obj.y, obj.width, obj.height);
                ctx.strokeText(el.RoomNo,obj.x+obj.width/2 - 10,obj.y+obj.height/2+5);
                ctx.restore();
            }
            img.src = el.PicURl;

            roomHashMap.push({
                minX : obj.x,
                maxX : obj.x + obj.width,
                minY : obj.y,
                maxY : obj.y + obj.height,
                no : el.RoomNo,
                message : el.Message,
                name : t.Name,
                price : t.Price
            });
        });
        ctx.closePath();
        ctx.restore();
    })
}

var getCoord = function (e){
    return {
        x : e.offsetX,
        y : e.offsetY
    }
};

var OBB = function (options,callback){
    var x = options.x,
        y = options.y;
    roomHashMap.map(function (el){
        if( x > el.minX && x < el.maxX && y < el.maxY && y > el.minY ){
            return callback(el);
        }
    })
};

function mouseHandle(e){
    OBB(getCoord(e),function (data){
        showPopFn();
        bindEvents();
    });
}

function gesStartHandle(e){
    gesStart = e.scale;
}

function gesEndHandle (e){
    gesEnd = e.scale;

    var se = ((gesEnd-gesStart)/2.5);
    currentScale += se;
    if( currentScale <= 0.5 ){
        currentScale = 0.5;
    }
    if( currentScale >= 2 ){
        currentScale = 2;
    }
    cvsParent.style.width = cvsParentWidth * currentScale + "px";
    cvsParent.style.height = cvsParentHeight * currentScale + "px";
    cvs.style.cssText = "resize:auto;-webkit-transform-origin:0% 0%;-webkit-transition:all .2s;-webkit-transform:scale("+ currentScale +")";
}


