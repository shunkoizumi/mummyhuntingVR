using UnityEngine;
using System.Collections;

public class MonsterSummonScript : MonoBehaviour {
	public float monspeed = 2.0f;
	public GameObject[] monster;
	public GameObject player;
	public GameObject DiveCamera;
	public Vector3 nextEmergePosition1;
	public Vector3 nextEmergePosition2;
	public Vector3 nextEmergePosition3;
	[SerializeField] ScoreController scoreController;
	Vector3 move = Vector3.zero;
	bool dead = false;
	bool isCoroutineDone = false;

	// コルーチン
	void Start () {
		StartCoroutine("AppearMonster");
	}

	void Update () {
		if (scoreController.score >= 150 && !isCoroutineDone) {
			print("3monster");
			isCoroutineDone = true;
			StartCoroutine ("AppearNum3Monster");
		}
	}
	//新たにモンスターを1体生成
	IEnumerator AppearNum3Monster(){
		for (int f = 10; f >= 0; f--) {
			int number3 = Random.Range (0, monster.Length);
			nextEmergePosition3 = GameObject.FindGameObjectWithTag ("emerge" + Random.Range (0, 6)).transform.position;
			Instantiate (monster [number3], nextEmergePosition3, Quaternion.Euler (0, 180, 0));
			yield return new WaitForSeconds (15.0f);
		}
	}
		
	//モンスターを配列の中からランダムに2体生成
	IEnumerator AppearMonster(){
		if (scoreController.score <= 150) {
			for (int f = 10; f >= 0; f--) {
				int number = Random.Range (0, monster.Length);
				int number2 = Random.Range (0, monster.Length);
				nextEmergePosition1 = GameObject.FindGameObjectWithTag ("emerge" + Random.Range (0, 6)).transform.position;
				nextEmergePosition2 = GameObject.FindGameObjectWithTag ("emerge" + Random.Range (0, 6)).transform.position;
				Instantiate (monster [number], nextEmergePosition1, Quaternion.Euler (0, 180, 0));
				Instantiate (monster [number2], nextEmergePosition2, Quaternion.Euler (0, 180, 0));
				player = GameObject.FindWithTag ("Player") as GameObject;
				yield return new WaitForSeconds (15.0f);
			}
		}


	}


}
