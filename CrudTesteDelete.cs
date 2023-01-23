[Fact]
public void Delete_ExistingId_DeleteRecord()
{
    // Arrange
    var existingRecord = new Record { Id = 1, Name = "Teste" };
    repository.Crate(existingRecord);

    // Act
    var result = repository.Delete(existingRecord.Id);