[Fact]
public void Update_ExistingId_UpdateRecord()
{
    // Arrange
    var existingRecord = new Record { Id = 1, Name = "Teste" };
    repository.Create(existingRecord);
    var updatedRecord = new Record { Id = 1, Name = "Teste 2" };
 
    // Act
    var result = repository.Update(updatedRecord);
 
    // Assert
    Assert.True(result);
    Assert.Equal(updatedRecord, repository.Get(updatedRecord.Id).Value);
    Assert.Equal(updatedRecord.Id, repository.Get(updatedRecord.Id).Value.Id);
}