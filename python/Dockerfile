FROM python:3.10-bullseye

WORKDIR /app

RUN pip install --upgrade pip

COPY requirements.txt .
RUN pip install --no-cache-dir -r requirements.txt

RUN mkdir -p spaceship/routers

COPY build/ ./build/

COPY spaceship/__init__.py ./spaceship/
COPY spaceship/config.py ./spaceship/

COPY spaceship/routers/ ./spaceship/routers/

COPY spaceship/app.py ./spaceship/
COPY spaceship/main.py .

EXPOSE 8080

CMD ["uvicorn", "spaceship.main:app", "--host=0.0.0.0", "--port=8080"]