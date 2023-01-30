package mmy.tdd

class StoragePlaceDbService(dao: DAO) {
  def persist(storagePlace: StoragePlace): Unit = {
    dao.persist(storagePlace)
    storagePlace.storedItems.getOrElse(Nil).foreach(
      storedItem => dao.persist(storedItem))
  }

}
