using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.S3.cloudformation.BucketResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html </remarks>
    public class SourceSelectionCriteriaProperty : DeputyBase, ISourceSelectionCriteriaProperty
    {
        /// <summary>``BucketResource.SourceSelectionCriteriaProperty.SseKmsEncryptedObjects``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html#cfn-s3-bucket-sourceselectioncriteria-ssekmsencryptedobjects </remarks>
        [JsiiProperty("sseKmsEncryptedObjects", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-s3.cloudformation.BucketResource.SseKmsEncryptedObjectsProperty\"}]}}", true)]
        public object SseKmsEncryptedObjects
        {
            get;
            set;
        }
    }
}