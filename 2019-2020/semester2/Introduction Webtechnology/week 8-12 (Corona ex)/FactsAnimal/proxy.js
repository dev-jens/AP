const express = require('express'),
    https = require('https');

const app = express();

const getAPI = (url) => new Promise((resolve, reject) => {
    return https
        .get(url, (response) => {
            let body = ''
            response.on('data', (chunk) => body += chunk)
            response.on('end', () => resolve(body))
        })
        .on('error', reject);
})

app.use((req, res, next) => {
    res.header('Access-Control-Allow-Origin', '*');
    next();
});

app.get('/', (req, res) => {
    res.send("Please use /api/random to retrieve facts");
});

app.get('/cats/random', (req, res) => {
    let url = "https://cat-fact.herokuapp.com/facts/random";
    if (req.query) {
        url += "?" + new URLSearchParams(req.query).toString();
    }
    return (async () => res.json(JSON.parse(await getAPI(url))))()
});

const PORT = process.env.PORT || 3030;
app.listen(PORT, () => console.log(`listening on ${PORT}`));