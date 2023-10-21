# Sample project for HC issue 6545

This is a sample project for an issue in HotChocolate regarding sorting.

To run the sample, use `dotnet run`.

Once started, go to `http://localhost:5000/graphql` in your browser.

The project behaves correctly for this query:

```
query listUsers {
    users(order: {evenNumberedAddress: {cityName: ASC}}) {
        nodes {
            name
        }
    }
}

```

but it fails when the query contains a variable, even though the logic is the same:


```
query listUsers($order: [UserSortInput!]!) {
    users(order: $order) {
        nodes {
            name
        }
    }
}

---- variables:
{
  "order": [
      {
        "evenNumberedAddress": {
          "cityName": "ASC"
        }
      }
    ]
}
```

The message complains about "Variable 'order' got an invalid value", but drilling down it seems related to the fact that the `Address` class does not have a public parameterless constructor.