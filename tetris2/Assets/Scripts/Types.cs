﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Types {
  internal readonly static int
    empty = 0, wall = 9,
    i = 1, o = 2, s = 3, z = 4, j = 5, l = 6, t = 7;
  static Type[] types = new Type[] {
    new I(), new O(), new J(), new T()
  };
  internal static Type Get() {
    return types[Random.Range(0, types.Length)];
  }
}
