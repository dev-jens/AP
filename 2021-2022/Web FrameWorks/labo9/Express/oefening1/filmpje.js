var express = require("express");
const bodyParser = require("body-parser");

var app = express();
app.use(bodyParser.json());

const mongoClient = require("mongodb").MongoClient;
const ObjectId = require("mongodb").ObjectId;
var db;

//db connect url
const url =
  "mongodb+srv://Jens:<password>@webframeworkscluster.cnsks.mongodb.net/test";
//db name
const dbName = "MyPeopleDB";

//connect met MongoDB
mongoClient.connect(url, (err, client) => {
  if (err != null) {
    console.log(err.message);
    throw err;
  }

  db = client.db(dbName);
  console.log("connceted to mongo");
});

let people =[
    {
        ID : 1,
        Name : "McEnroe",
        Firstname: "John"
    },
    {
        ID : 2,
        Name : "Smith",
        Firstname: "Will"
    }
]


var router = express.Router();
router.route('/people')
    .get((req,res) => {
        res.json(people);
    })
    .post((req,res) => {

    })
    .delete((req,res) => {
        let query = req.query;
    })

router.route('/people/:id')
 .get((req,res) => {
    res.json(people.filter(person => person.ID == req.params.id)[0]);
})
router
  .route("/people")
  .get((req, res) => {
    //Select
    let query = req.query;
    db.collection("people")
      .find(query)
      .toArray((err, person) => {
        res.json(person);
      });
  })
  .post((req, res) => {
    //Update
    db.collection("people").insert(req.body, (err, result) => {
      res.json(result.ops[0]);
    });
  })
  .delete((req, res) => {
    //Delete
    let query = req.query;
  });

router
  .route("/people/:id")
  .get((req, res) => {
    //Select
    let id = req.params.id;
    let query = { _id: ObjectId(id) };
    db.collection("people")
      .find(query)
      .toArray((err, person) => {
        res.json(person);
      });
  })
  .put((req, res) => {
    //Update
    let id = req.params.id;
    let query = { _id: ObjectId(id) };
    db.collection("people").update(query, req.body, (err, result) => {
      if (err != null) {
        res.statusCode = 500;
        res.end();
      } else {
        db.collection("people")
          .find(query)
          .toArray((err, people) => {
            if (err != null) {
              res.statusCode = 500;
              res.end();
            }
            res.json(people);
          });
      }
    });
  })
  .delete((req, res) => {
    //Delete
    let id = req.params.id;
    let query = { _id: ObjectId(id) };
    db.collection("people").deleteOne(query),
      (err, result) => {
        res.end();
      };
  });

app.use("/api", router);

app.listen(8080, () => {
  console.log("server is running");
});
