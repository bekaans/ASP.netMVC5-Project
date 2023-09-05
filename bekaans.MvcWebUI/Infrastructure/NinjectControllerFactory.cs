using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bekaans.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory
    {
        private IKernel _ninjectKernel;
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }
        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBllBindings();
        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productdal", new EFProductDAL());
        }
    }
}
}