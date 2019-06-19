using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Localization;

namespace LanguageOmg.Services
{
    public interface ITesting : IApplicationService
    {
        void CreateLanguage(LanguageInfo input)
    }
}
