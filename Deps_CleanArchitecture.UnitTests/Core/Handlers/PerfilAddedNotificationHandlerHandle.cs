﻿//using Deps_CleanArchitecture.Core.Interfaces;
//using Deps_CleanArchitecture.Core.MetricaAggregate;
//using Deps_CleanArchitecture.Core.ParametrizacaoMetricaAggregate.Handlers;
//using Deps_CleanArchitecture.Core.Entities.PerfilAggregate;
//using Deps_CleanArchitecture.Core.Entities.PerfilAggregate.Events;
//using Moq;
//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using Xunit;

//namespace Deps_CleanArchitecture.UnitTests.Core.Handlers
//{
//    public class PerfilAddedNotificationHandlerHandle
//    {
//        private PerfilAddedNotificationHandler _handler;
//        private Mock<IParametrizacaoMetricaService> _parametrizacaoMetricaServiceMock;

//        public PerfilAddedNotificationHandlerHandle()
//        {
//            _parametrizacaoMetricaServiceMock = new Mock<IParametrizacaoMetricaService>();
//            _handler = new PerfilAddedNotificationHandler(_parametrizacaoMetricaServiceMock.Object);
//        }

//        [Fact]
//        public async Task ThrowsExceptionGivenNullEventArgument()
//        {
//            Exception ex = await Assert.ThrowsAsync<ArgumentNullException>(() => _handler.Handle(null, CancellationToken.None));
//        }

//        [Fact]
//        public async Task AddParametrizacaoMetricaGivenEventInstance()
//        {
//            await _handler.Handle(new PerfilAddedEvent(Perfil.Factory.NovoPerfil("teste", 1)), CancellationToken.None);

//            _parametrizacaoMetricaServiceMock.Verify(service => service.AdicionarParametrizacoesMetricaPorPerfilAsync(It.IsAny<Perfil>()), Times.Once);
//        }

//        [Fact]
//        public async Task DoNotCallAddParametrizacaoMetricaPorPerfilGivenEventInstance()
//        {
//            await _handler.Handle(new PerfilAddedEvent(Perfil.Factory.NovoPerfil("teste", 1)), CancellationToken.None);

//            _parametrizacaoMetricaServiceMock.Verify(service => service.AdicionarParametrizacoesMetricaPorMetricaAsync(It.IsAny<Metrica>()), Times.Never);
//        }
//    }
//}
