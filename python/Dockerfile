FROM python:3.10-alpine

WORKDIR /app

RUN apk add --no-cache \
    gcc \
    musl-dev \
    linux-headers \
    && rm -rf /var/cache/apk/*

RUN pip install --upgrade pip

COPY requirements.txt .
RUN pip install --no-cache-dir -r requirements.txt

RUN apk del gcc musl-dev linux-headers

COPY build/ ./build/

COPY spaceship/ ./spaceship/
COPY spaceship/main.py .

EXPOSE 8080

CMD ["uvicorn", "spaceship.main:app", "--host=0.0.0.0", "--port=8080"]