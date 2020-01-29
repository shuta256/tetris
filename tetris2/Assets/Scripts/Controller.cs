﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
  public GameObject prfbCell;
  internal SpriteRenderer Cell() {
    return Instantiate(prfbCell)
      .GetComponent<SpriteRenderer>();
  }
  Board board = new Board();
  Key key = new Key();
  void Start() {
    key.Init(this, board);
    board.Init(this, key);
    board.Render();
  }
  static int wait = 60;
  int fWait = wait;
  void Update() {
    key.Process();
    fWait--;
    if (fWait <= 0) {
      board.Drop();
      fWait = wait;
    }
    board.Render();
  }
  internal void SpeedUp() {
    fWait -= wait / 2;
  }
}

