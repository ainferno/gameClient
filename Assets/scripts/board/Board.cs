using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardEngine
{
	public class Board : MonoBehaviour
	{
		GameObject[] tiles = new GameObject[1];
		int[] tileId = new int[1];
		int[,] pos = new int[8,8];
		int playerOneId, playerTwoId;
		bool turn;
		public Board(GameObject[] setOfTiles, int[] playerIds)
		{
			int id = 0;
			playerOneId = playerIds[0];
			playerTwoId = playerIds[1];
			turn = true;
			foreach (GameObject tile in setOfTiles) {
				tiles[id] = tile;
				tileId[id] = id;
				id++;
			}

			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 8; j++) {
					pos[i, j] = tileId[0];
					Instantiate(tiles[0], new Vector3(i - (float)3.5, (float)3.5 - j, 1), Quaternion.identity);
				}

		}
		public void finish()
		{
			foreach (GameObject tile in tiles)
			{
				Destroy(tile);
			}
		}
		public int getCurPlayerId()
		{
			if (turn)
				return playerOneId;
			else
				return playerTwoId;
		}
		public void changeTurn()
		{
			turn = !turn;
		}
	}
}