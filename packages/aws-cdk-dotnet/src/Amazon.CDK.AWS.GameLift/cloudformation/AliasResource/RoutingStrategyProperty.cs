using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.GameLift.cloudformation.AliasResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html </remarks>
    public class RoutingStrategyProperty : DeputyBase, IRoutingStrategyProperty
    {
        /// <summary>``AliasResource.RoutingStrategyProperty.FleetId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html#cfn-gamelift-alias-routingstrategy-fleetid </remarks>
        [JsiiProperty("fleetId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object FleetId
        {
            get;
            set;
        }

        /// <summary>``AliasResource.RoutingStrategyProperty.Message``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html#cfn-gamelift-alias-routingstrategy-message </remarks>
        [JsiiProperty("message", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Message
        {
            get;
            set;
        }

        /// <summary>``AliasResource.RoutingStrategyProperty.Type``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html#cfn-gamelift-alias-routingstrategy-type </remarks>
        [JsiiProperty("type", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object Type
        {
            get;
            set;
        }
    }
}