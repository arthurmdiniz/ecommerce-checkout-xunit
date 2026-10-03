using EcommerceCheckout.App;
using Xunit;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
	private readonly PedidoService _service = new();

	[Fact]
	public void GerarCodigoRastreio_DeveGerarMascaraExata()
	{
		var resultado = _service.GerarCodigoRastreio("SUDESTE", 42);

		Assert.Equal("SUDESTE-0042", resultado);
	}

	[Fact]
	public void CalcularPontosFidelidade_DeveCalcularPontosCorretamente()
	{
		var resultado = _service.CalcularPontosFidelidade(150);

		Assert.Equal(30, resultado);
	}

	[Fact]
	public void FreteGratis_DeveSerVerdadeiroParaClienteVipAbaixoDeDuzentosReais()
	{
		var resultado = _service.TemDireitoAFreteGratis(150, true);

		Assert.True(resultado);
	}

	[Fact]
	public void FreteGratis_DeveSerFalsoParaClienteNaoVipAbaixoDeDuzentosReais()
	{
		var resultado = _service.TemDireitoAFreteGratis(199, false);

		Assert.False(resultado);
	}
}
