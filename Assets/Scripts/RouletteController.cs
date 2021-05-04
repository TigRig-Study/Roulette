using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
  float rotSpeed = 0;

  private void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      // 使うところで Time.deltaTime を乗算すると秒間３回転するスピードになる
      rotSpeed = 360f * 2;
    }

    transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
  }
}
