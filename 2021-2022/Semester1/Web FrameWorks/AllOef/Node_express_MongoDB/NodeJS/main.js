const http = require('http');
const fs = require('fs');

const host = 'localhost'
const port = 8080

const requestListener = function (req, res) {
    fs.readFile('index.html',function (err, data){

        res.setHeader("Content-Type","text/html") //application/json
        res.writeHead(200);
        res.write(data);
        res.end('<b>{"message": "Hallo vanuit node.js" }</b>'); 
    }) 
}

const server = http.createServer(requestListener);
server.listen(port, host, () => {
    console.log(`server is running on http://${host}:${port}`)
});