package mmy.tdd


import org.scalatest.matchers.must.Matchers
import org.scalamock.scalatest.MockFactory
import org.scalatest.freespec.AnyFreeSpec

/**Mocking Traits*/

class UsingScalaMockSample extends AnyFreeSpec with Matchers with MockFactory {

  "ScalaMocks can create mocks of traits" -{
    "can create a mock for a trait" in {
      val daoMock = mock[DAO]

      //set up actual values to be used
      val hammer: StoredItem = new StoredItem("Hammer", "Hammer with a black stick")
      val screwdriver: StoredItem = new StoredItem("Screwdriver", "Red screwdriver")
      val knife: StoredItem = new StoredItem("Knife", "Small knife")

      val garageTable: StoragePlace = new StoragePlace("Table in garage","Working table in garage", Some(List(hammer, screwdriver, knife)))

      val storagePlaceDbService = new StoragePlaceDbService(daoMock)

      (daoMock.persist _).expects(garageTable)
      (daoMock.persist _).expects(hammer)
      (daoMock.persist _).expects(knife)
      (daoMock.persist _).expects(screwdriver)


      storagePlaceDbService.persist(garageTable)

    }

    "can also mock regular object, and along with other traits" in{
      val daoMock = mock[DAO]

      //set up actual values to be used
      val hammer: StoredItem = mock[StoredItem]
      val screwdriver: StoredItem = mock[StoredItem]
      val knife: StoredItem = mock[StoredItem]

      val garageTable: StoragePlace = mock[StoragePlace]

      val storagePlaceDbService = new StoragePlaceDbService(daoMock)

      inSequence {
        (daoMock.persist _).expects(garageTable)
        (garageTable.getStoredItems _).expects().returning(Some(List(hammer, screwdriver, knife)))
        (daoMock.persist _).expects(hammer)
        (daoMock.persist _).expects(screwdriver)
        (daoMock.persist _).expects(knife)
      }

      storagePlaceDbService.persist(garageTable)
    }
  }
}
