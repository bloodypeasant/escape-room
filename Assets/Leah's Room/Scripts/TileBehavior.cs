using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
    public class TileBehavior : MonoBehaviour
    {
        private bool hasBeenPressed = false;
        public PuzzleBehavior puzzleBehavior;

        private void Start() {
            puzzleBehavior = GameObject.Find("PuzzleObj").GetComponent<PuzzleBehavior>();
        }

        private void OnCollisionEnter(Collision other) {
            Debug.Log(hasBeenPressed);
            if (other.gameObject.name == "PlayerObj") {
                if (!hasBeenPressed) {
                    hasBeenPressed = true;
                } else {
                    //reset all tiles
                }
                puzzleBehavior.TileUpdate();
            }
        }

        public bool GetIsPressed() {
            return hasBeenPressed;
        }
    }
}
