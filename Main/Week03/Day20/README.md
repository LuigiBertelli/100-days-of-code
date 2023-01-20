# API Challenge

## Requirements

Design an API endpoint that provides autocomplete suggestions for cities.

- the endpoint is exposed at `/Cities`

#### Sample responses

These responses are meant to provide guidance. The exact values can vary based on the data source and scoring algorithm.

**Near match**

    GET /suggestions?q=Londo&latitude=43.70011&longitude=-79.4163

```json
{
  "suggestions": [
    {
        "place_id": "ChIJ1YMtb8cU6YARSHa612Q60cg",
        "name": "Santa Barbara, CA, USA",
        "location": {
            "lat": 34.4208305,
            "lng": -119.6981901
        },
        "score": 0.6
    },
    {
        "place_id": "ChIJXzTd3pedyJQRdVNkP3FYCPo",
        "name": "Santa Bárbara d'Oeste, State of São Paulo, Brazil",
        "location": {
            "lat": -22.7560892,
            "lng": -47.4153925
        },
        "score": 0.3
    },
    {
        "place_id": "ChIJk1FlP_grZI8R3WlHYd1IvGA",
        "name": "Santa Barbara, Honduras",
        "location": {
            "lat": 14.9219177,
            "lng": -88.2375991
        },
        "score": 0.6
    },
    {
        "place_id": "ChIJ9UO7bcOLa5YRPrSpVNrGRvc",
        "name": "Santa Bárbara, Chile",
        "location": {
            "lat": -37.6643902,
            "lng": -72.0245951
        },
        "score": 0.6
    },
    {
        "place_id": "ChIJS5cfVYZBkTMRRPoFFvhC_V4",
        "name": "Santa Barbara, Pangasinan, Philippines",
        "location": {
            "lat": 15.9773962,
            "lng": 120.4242401
        },
        "score": 0.3
    }
}
```

**No match**

    GET /suggestions?q=SomeRandomCityInTheMiddleOfNowhere

```json
{
  "suggestions": []
}
```
