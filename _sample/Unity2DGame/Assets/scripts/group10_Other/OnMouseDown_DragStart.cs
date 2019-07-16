using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、ドラッグする
public class OnMouseDown_DragStart: MonoBehaviour {

	bool dragFlag = false;

	void OnMouseDown() {
		dragFlag = true;
	}
	void OnMouseUp() {
		dragFlag = false;
	}
	void Update() { // ずっと行う
		if (dragFlag) {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = -5f; // 手前に表示
            this.gameObject.transform.position = position;
		}
	}
}
