# plaything

An API to help me play around with all things containers

## Getting started

Dockerfile is included, so just build yourself an image and call it whatever you like

## Usage

There are a few endpoints you can hit:
- GET http://{container}:5000/hello 
  - This will return 200 OK, with some text and the service will log the fact that it said hello to stdout.
- GET http://{container}:5000/crash
  - The service will log that it's about to die to stdout and then immediately terminate with an exit code of 666.
- GET http://{container}:5000/code/{code}
  - The service will respond with whatever http status code you provide, and log the fact that it did that to stdout.
