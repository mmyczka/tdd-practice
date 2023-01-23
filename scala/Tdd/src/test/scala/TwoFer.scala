package org.tdd

import org.scalatest.flatspec.AnyFlatSpec
import org.scalatest.matchers.should.Matchers

class TwoFerTest extends AnyFlatSpec with Matchers{

  "TwoFer" should "return 'One for Emma, one for me.' when given name 'Emma'" in {
    TwoFer.twofer("Emma") should be ("One for Emma, one for me.")
  }

  it should "return 'One for Bob, one for me.' when given name 'Bob'" in{
    TwoFer.twofer("Bob") should be ("One for Bob, one for me.")
  }

  it should "return 'One for you, one for me.' when given no name" in{
    TwoFer.twofer() should be ("One for you, one for me.")
  }

}
