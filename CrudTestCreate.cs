[Fact]
public void Create_NewRecord_CreateRecord()
{
    // Arrange
    var newRecord = new Record { Id = 1, Name = "Teste" };

    // Act
    var result = repository.Create(newRecord);

    // Assert
    Assert.True(result);
    Assert.Equal(newRecord, repository.Get(newRecord.Id).Value);
    Assert.Equal(newRecord.Id, repository.Get(newRecord.Id).Value.Id);
}
