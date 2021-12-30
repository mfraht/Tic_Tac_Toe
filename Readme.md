API To start Game:
POST API
/api/Games/start
Request body [choose between X or O]
{
  "gameId": "string",
  "player": "string"
}
Example:
{
  "gameId": "1000",
  "player": "X"
}
Second Player will take the opiste chooice 'O'
Response body:

Response body: [Return game Id, player one Id and player two Id.]
"{\"id\":\"1000\",\"Board\":[\"-\",\"-\",\"-\",\"-\",\"-\",\"-\",\"-\",\"-\",\"-\"],\"LastMoveOn\":\"2021-12-29T21:26:38.9629001-07:00\",\"FirstPlayer\":\"X\",\"SecondPlayer\":\"O\",\"Winner\":\"-\"}"

- API for Players Move
POST
​/api​/Games​/move
Request body
{
  "id": "string",
  "player": "string",
  "position": 0
}
Example:
{
  "id": "1000",
  "player": "O",
  "position": 4
}
Response body
Download
true
Board = {[0]:'X',[1]:'-',[2]:'-',[3]:'-',[4]:'O',[5]:'-',[6]:'-',[7]:'-',[8]:'-'}

- API to list of currently running games
GET 