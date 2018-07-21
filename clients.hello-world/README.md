# Docker

## Docker Registry

A Docker image can be pushed to a registry, it's identified as follows:

```
<registry>/<user>/<repository>:<tag>
```

### Examples

A personal repository on Docker Hub:
* docker.io/tjaard123/hello-world:1.0

Docker knows about Docker Hub registry and don't need docker.io:
* microsoft/dotnet:2.1-sdk
* microsoft/dotnet:2.1-runtime
* microsoft/dotnet:2.1-sdk-alpine
* microsoft/dotnet:1.0-runtime
* microsoft/iis

Some "root" images don't have a user:
* node:9.11
* node:9.11-alpine
* node:6

Private repo on AWS:
* 242175254145.dkr.ecr.eu-west-1.amazonaws.com/hello-world

A microservices application example:
* bank/service-accounts
* bank/service-payments
* bank/client-customer
* bank/client-admin

## K8s

minikube start --vm-driver=hyperv --hyperv-virtual-switch=minikube --alsologtostderr

## Using...
1. Dockerfile describes the image:

```
FROM nginx:alpine
COPY . /usr/share/nginx/html
```

2. Build the image:

```
$ docker build -t tjaard123/hello-world .
```

3. Tag & push the image to Docker Hub:

```
docker tag hello-world tjaard123/hello-world # do you need to tag?
docker push tjaard123/hello-world
```

docker run tjaard123/hello-world -p 8080:80
docker logs <container>


# K8s Deployment

Let's walk through a K8s deployment yml:

```yml
apiVersion: apps/v1 # Kubernetes API version
kind: Deployment
metadata:
  name: nginx-deployment
spec:
  selector:
    matchLabels:
      app: nginx
  replicas: 2 # tells deployment to run 2 pods matching the template
  template:
    metadata:
      labels:
        app: nginx
    spec:
      containers:
      - name: nginx
        image: nginx:1.7.9
        ports:
        - containerPort: 80
```

```yml
apiVersion: apps/v1
```

The version of K8s api running in the cluster, you can find the api versions:

```sh
kubectl api-versions
   apiextensions.k8s.io/v1beta1
   apiregistration.k8s.io/v1
   apps/v1
   ...
```

```yml
kind: Deployment
```