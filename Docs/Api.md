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
  "id": "57f79380-3556-4c0e-8545-7daa5369ca5c",
  "firstName": "John",
  "lastName": "Doe",
  "email": "john_doe@email.com",
  "token": "token"
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
  "id": "e1c9cd08-5fdb-4d71-9a94-1c7ff1aa2aa7",
  "firstName": "firstName",
  "lastName": "lastName",
  "email": "john_doe@email.com",
  "token": "token"
}
```