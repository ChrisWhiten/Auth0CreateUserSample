# Auth0CreateUserSample
This is a sample C# console application for creating users in [Auth0](http://www.auth0.com) (with bonus `app_metadata` for user-defined fields to be encoded in authentication tokens).

As input, this application takes command line parameters defining the username and email to create a user with, as well as the domain the user should belong to and a token to authenticate the user-creation call.  These parameters are denoted as:

```
  -e, --email_address    Required. The email address corresponding to the user
                         you wish to create

  -u, --username         Required. The username corresponding to the user you
                         wish to create

  -d, --domain           Required. The Auth0 domain that you wish to create the
                         user on

  -t, --token            Required. A token with 'create:users' scope from your
                         Auth0 account. (Generatable at
                         https://auth0.com/docs/api/v2#!/Users/post_users)

  --help                 Display this help screen.
```

The application is called by `Auth0CreateUserSample.exe -e test@user.com -u testuser -d myapp.auth0.com -t [redacted - a token with create:users scope]`.

