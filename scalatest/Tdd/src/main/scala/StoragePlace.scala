package mmy.tdd

class StoragePlace(val name: String, val description: String, val storedItems: Option[List[StoredItem]]) {
  def this(name: String, description: String) = this(name, description, None)

}
