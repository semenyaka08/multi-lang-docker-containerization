FROM golang:1.21 AS builder

WORKDIR /app

COPY go.mod ./

RUN go mod download
RUN go mod tidy

COPY . .

RUN CGO_ENABLED=0 GOOS=linux go build -a -ldflags '-extldflags "-static"' -o /app/mygoapp .

FROM gcr.io/distroless/static-debian12

WORKDIR /app

COPY --from=builder /app/mygoapp /app/mygoapp

COPY templates /app/templates

EXPOSE 8080

CMD ["/app/mygoapp", "serve"]