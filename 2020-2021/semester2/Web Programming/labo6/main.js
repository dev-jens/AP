class ball {
    constructor(_x, _y, _straal, _speedX, _speedY) {
        // set starting stats of the bal
        this.x = _x
        this.y = _y
        this.straal = _straal;
        this.speedX = _speedX;
        this.speedY = _speedY;

    }

    move() {
        // update x,y values 
        this.x += this.speedX;
        this.y += this.speedY;

        // checks for collision with canvas
        if (this.x >= 500 || this.x <= 0) {
            this.speedX = this.speedX * -1;
        }
        if (this.y >= 500 || this.y <= 0) {
            this.speedY = this.speedY * -1;
        }
    }
    draw(ctx) {
        // draws ball
        ctx.beginPath();
        ctx.arc(this.x, this.y, this.straal, 0, Math.PI * 2, true);
        ctx.fill();
        ctx.closePath();
    }

}

class paddle {

    constructor(x, y) {
        //start position paddle
        this.x = x
        this.y = y
    }

    draw(ctx) {
        // draws paddle
        ctx.beginPath()
        ctx.rect(this.x, this.y, 30, 50)
        ctx.fill();
        ctx.closePath();
    }

}
/* function that generates ramdom int between 0 and max
function getRandomInt(max) {
    return Math.floor(Math.random() * max);
}
*/

document.addEventListener("DOMContentLoaded", (event) => {
    let canvas = document.querySelector("canvas");
    let ctx = canvas.getContext("2d");
    let paddleLeft = new paddle(25, 0)
    let paddleRight = new paddle(450, 250)
    let gameBal = new ball(250, 250, 10, 4, 5)

    /*let ballen = []
    
    ballen.push(new ball(getRandomInt(500), getRandomInt(500), getRandomInt(30), getRandomInt(15), getRandomInt(15))) */

    function Animate() {
        //clear
        ctx.clearRect(0, 0, 500, 500);

        //update
        //ballen[i].move()
        gameBal.move()

        if (paddleHit()) {
            gameBal.speedX *= -1
        }

        //draw
        //ballen[i].draw(ctx)
        paddleRight.draw(ctx)
        paddleLeft.draw(ctx)
        gameBal.draw(ctx)

        setTimeout(Animate, 33)
    }

    canvas.addEventListener("mousemove", (move) => {
        // move rectangle on the y-as with mouse 
        paddleLeft.y = move.clientY;
        //paddleLeft.x = move.clientX;
    });
    canvas.addEventListener("keydown", (e) => {
        switch(e.keyCode) {
            case 38:
                paddleRight.y -= 8
                break;
            case 40:
                paddleRight.y += 8
                break;  
        }   
    });
   
    function paddleHit() {
        if (gameBal.y > paddleLeft.y && gameBal.y < paddleLeft.y + 50) {
            if (gameBal.x < paddleLeft.x + 30) {
                return true
            }
        }
        return false
    }

    Animate();


})