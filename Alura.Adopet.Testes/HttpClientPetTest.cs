using Alura.Adopet.Console.Servicos;

namespace Alura.Adopet.Testes
{
    public class HttpClientPetTest
    {
        [Fact]
        public async Task ListaPetsDeveRetornarUmaListaNaoVazia()
        {
            //Arrange
            var httpClientePet = new HttpClientPet();

            //Act
            var result = await httpClientePet.ListPetsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task LancarEscecaoQuandoApiFora()
        {
            //Arrange
            var httpClientePet = new HttpClientPet();

            //Act
            await Assert.ThrowsAnyAsync<Exception>(() => httpClientePet.ListPetsAsync());
        }
    }
}