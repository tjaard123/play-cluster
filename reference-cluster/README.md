# Simple cluster with minikube

Work in Progress

tjaard123/hello-world image deployed to cluster and accessed via a service

Deploy a namespace, the app and a service

```
$ kubectl apply -f ./namespace.yaml
$ kubectl apply -f ./deployment.yaml
$ kubectl apply -f ./service.yaml
```

Access the hello-world web on the pod within the cluster through minikube ip and NodePort, e.g. `http://192.168.1.10:30080`:

```
$ minikube ip
192.168.1.10
```