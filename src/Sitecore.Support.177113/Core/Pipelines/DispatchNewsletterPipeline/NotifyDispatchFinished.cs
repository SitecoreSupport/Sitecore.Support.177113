using Sitecore.Analytics.Tracking;
using Sitecore.ExM.Framework.Diagnostics;
using Sitecore.Modules.EmailCampaign.Core;
using Sitecore.Modules.EmailCampaign.Core.Pipelines.DispatchNewsletter;

namespace Sitecore.Support.Modules.EmailCampaign.Core.Pipelines.DispatchNewsletter
{
    public class NotifyDispatchFinished : Sitecore.Modules.EmailCampaign.Core.Pipelines.DispatchNewsletter.NotifyDispatchFinished
    {
        // Methods
        public NotifyDispatchFinished() : base()
        {
        }

        public NotifyDispatchFinished(CoreFactory coreFactory, ILogger logger): base(coreFactory, logger)
        {
        }

        public void Process(DispatchNewsletterArgs args)
        {
            using (new DefinitionDatabaseSwitcher("master"))
            {
                base.Process(args);
            }
        }
    }
}
