package mmy.tdd

object BookExercises {

  def isSorted[A](as: Array[A], gt: (A, A) => Boolean): Boolean = {
    def loop(n: Int): Boolean = {
      if (n + 1 >= as.length) true
      else if (!gt(as(n), as(n + 1))) false
      else loop(n+1)
    }

    loop(0)
  }

}
