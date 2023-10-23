# Bubber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "John",
    "lastName": "Doe",
    "email": "john_doe@email.com",
    "password": "password"
}
```
### Register Response

```json
200 OK
```
```json
{
    "id": "",
    "firstName": "John",
    "lastName": "Doe",
    "email": "john_doe@email.com",
    "token": ""
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "john_doe@email.com",
    "password": "password"
}
```

#### Login Response

```json
200 OK
```
```json
{

}
```