package mmy.tdd

import org.scalamock.scalatest.MockFactory
import org.scalatest.freespec.AnyFreeSpec
import org.scalatest.matchers.must.Matchers

class BookExercisesTest extends AnyFreeSpec with Matchers with MockFactory{

  "isSorted function returns" -{
    "true for" -{
      "Array(1, 2, 3) and comparison _ < _" in {
        BookExercises.isSorted(Array(1, 2, 3), (a: Int, b: Int) =>  a < b) must be (true)
      }
      "Array(3, 2, 2, 1) and comparison _ >= _" in {
        BookExercises.isSorted(Array(3, 2, 2, 1), (a: Int, b: Int) => a >= b) must be (true)
      }
    }
    "false for" - {
      "Array(1, 2, 2, 3) and comparison _ < _" in {
        BookExercises.isSorted(Array(1, 2, 2, 3), (a: Int, b: Int) => a < b) must be (false)
      }
      "Array(3, 2, 4, 1) and comparison _ >= _" in {
        BookExercises.isSorted(Array(3, 2, 4, 1), (a: Int, b: Int) => a >= b) must be (false)
      }
    }
  }
}
