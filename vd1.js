
const http = require("http");

const hostname = "localhost";

const port = 3000;
var solan = 0;

const server = http.createServer(
    (req, res) =>{
        res.statusCode = 200;
        res.setHeader("content-type","application/json");
        res.end("hello!!!" + solan);
        console.log ("--- request !!!", solan++,req.url);
    }
)

server.listen ( port, hostname, 
    () => {
        console.log("listen !!!");
    });