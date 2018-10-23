using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour 
{
	[SerializeField] private Vector3 offset; //Responsável por armazenar o Vetor que deve ser usado para variavar a posição da Câmera com relação ao jogador
	[SerializeField] private float smoothTimeX, smoothTimeY; //Tempo base para a realização da suavização
    [SerializeField] private float Max_X, Min_X, Max_Y, Min_Y; //Limites da fase;
    [SerializeField]  private Transform target; // Alvo para de terminar a posição da Câmera
	private Vector2 Velocity; //Velocidade de referência
	private float posX, posY; // Posições finais


	void FixedUpdate()
	{
        posY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref Velocity.y, smoothTimeY);
        posX = Mathf.SmoothDamp(transform.position.x, target.position.x, ref Velocity.x, smoothTimeX);

        transform.position = new Vector3(Mathf.Clamp(posX, Min_X, Max_X), Mathf.Clamp(posY, Min_Y, Max_Y), transform.position.z) - offset;
    }

 
}
