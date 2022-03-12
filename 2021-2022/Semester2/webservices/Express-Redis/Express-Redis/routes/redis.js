const express = require('express')
var router = express.Router()
const fetch = require('node-fetch')
const Redis = require('ioredis')
const redis = new Redis()

const API_URL = "https://api.github.com/users/dev-jens/repos";

router.get('/:name', async (req, res) => {

})
router.get('/repos', (req, res) => {
	res.send("ok")
	fetch(API_URL)
		.then(res => res.json())
		.then(data => {
			console.log(data)
		})
		.catch(err => console.error(err))
})

module.exports = router