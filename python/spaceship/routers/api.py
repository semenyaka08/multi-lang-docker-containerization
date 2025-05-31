from fastapi import APIRouter
import numpy as np


router = APIRouter()


@router.get('')
def hello_world() -> dict:
    return {'msg': 'Hello, World!'}

@router.get("/matrix-mult")
async def matrix_mult():
    a = np.random.rand(10, 10)
    b = np.random.rand(10, 10)
    product = a.dot(b)
    return {
        "matrix_a": a.tolist(),
        "matrix_b": b.tolist(),
        "product": product.tolist(),
    }