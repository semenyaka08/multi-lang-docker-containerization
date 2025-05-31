FROM golang:1.21

WORKDIR /app

COPY go.mod ./

RUN go mod download

RUN go mod tidy

COPY . .

RUN go build -v -o mygoapp .

EXPOSE 8080

CMD ["./mygoapp", "serve"]