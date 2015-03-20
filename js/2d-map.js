var cvs,ctx;
var unit = 20,
    rows = 30;
    cols = 30;

var roomHashMap = [];

function handle (){
    cvs = document.getElementById("cvs");
    ctx = cvs.getContext("2d");
    cvs.addEventListener("click", mouseHandle);
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
    roomList.map(function (el,i){
        var t = roomType[el.RoomTypeId];
        ctx.fillStyle = t.Color;
        var obj = {
            x : el.PositionX*unit,
            width : addPoint(el.Width*unit),
            y : el.PositionY*unit,
            height : addPoint(el.Height*unit)
        };
        ctx.fillRect(obj.x,obj.y,obj.width,obj.height);
        ctx.strokeText(el.RoomNo,obj.x+obj.width/2 - 10,obj.y+obj.height/2+5);
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
}

var getCoord = function (e){
    return {
        x : e.clientX - cvs.offsetLeft,
        y : e.clientY - cvs.offsetTop
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
        alert(1);
        // roomName.innerHTML = data.name;
        // roomNo.innerHTML = data.no;
        // roomPrice.innerHTML = data.price;
        // roomMsg.innerHTML = data.message;
    });
}