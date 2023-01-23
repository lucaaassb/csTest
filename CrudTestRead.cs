[Fact]
public void Read_ExistingId_ReturnRecord()
{
    // Arrange
    var existingRecord = new Record { Id = 1, Name = "Teste" };
    repository.Create(existingRecord);

    // Act
    var result = repository.Get(existingRecord.Id);

    // Assert
    Assert.True(result.HasValue);
    Assert.Equal(existingRecord, result.Value);
    Assert.Equal(existingRecord.Id, result.Value.Id);
}