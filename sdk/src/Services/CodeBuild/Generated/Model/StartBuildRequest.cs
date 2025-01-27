/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the StartBuild operation.
    /// Starts running a build.
    /// </summary>
    public partial class StartBuildRequest : AmazonCodeBuildRequest
    {
        private ProjectArtifacts _artifactsOverride;
        private string _buildspecOverride;
        private ProjectCache _cacheOverride;
        private string _certificateOverride;
        private ComputeType _computeTypeOverride;
        private EnvironmentType _environmentTypeOverride;
        private List<EnvironmentVariable> _environmentVariablesOverride = new List<EnvironmentVariable>();
        private int? _gitCloneDepthOverride;
        private GitSubmodulesConfig _gitSubmodulesConfigOverride;
        private string _idempotencyToken;
        private string _imageOverride;
        private ImagePullCredentialsType _imagePullCredentialsTypeOverride;
        private bool? _insecureSslOverride;
        private LogsConfig _logsConfigOverride;
        private bool? _privilegedModeOverride;
        private string _projectName;
        private int? _queuedTimeoutInMinutesOverride;
        private RegistryCredential _registryCredentialOverride;
        private bool? _reportBuildStatusOverride;
        private List<ProjectArtifacts> _secondaryArtifactsOverride = new List<ProjectArtifacts>();
        private List<ProjectSource> _secondarySourcesOverride = new List<ProjectSource>();
        private List<ProjectSourceVersion> _secondarySourcesVersionOverride = new List<ProjectSourceVersion>();
        private string _serviceRoleOverride;
        private SourceAuth _sourceAuthOverride;
        private string _sourceLocationOverride;
        private SourceType _sourceTypeOverride;
        private string _sourceVersion;
        private int? _timeoutInMinutesOverride;

        /// <summary>
        /// Gets and sets the property ArtifactsOverride. 
        /// <para>
        /// Build output artifact settings that override, for this build only, the latest ones
        /// already defined in the build project.
        /// </para>
        /// </summary>
        public ProjectArtifacts ArtifactsOverride
        {
            get { return this._artifactsOverride; }
            set { this._artifactsOverride = value; }
        }

        // Check to see if ArtifactsOverride property is set
        internal bool IsSetArtifactsOverride()
        {
            return this._artifactsOverride != null;
        }

        /// <summary>
        /// Gets and sets the property BuildspecOverride. 
        /// <para>
        /// A build spec declaration that overrides, for this build only, the latest one already
        /// defined in the build project.
        /// </para>
        /// </summary>
        public string BuildspecOverride
        {
            get { return this._buildspecOverride; }
            set { this._buildspecOverride = value; }
        }

        // Check to see if BuildspecOverride property is set
        internal bool IsSetBuildspecOverride()
        {
            return this._buildspecOverride != null;
        }

        /// <summary>
        /// Gets and sets the property CacheOverride. 
        /// <para>
        /// A ProjectCache object specified for this build that overrides the one defined in the
        /// build project.
        /// </para>
        /// </summary>
        public ProjectCache CacheOverride
        {
            get { return this._cacheOverride; }
            set { this._cacheOverride = value; }
        }

        // Check to see if CacheOverride property is set
        internal bool IsSetCacheOverride()
        {
            return this._cacheOverride != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateOverride. 
        /// <para>
        /// The name of a certificate for this build that overrides the one specified in the build
        /// project.
        /// </para>
        /// </summary>
        public string CertificateOverride
        {
            get { return this._certificateOverride; }
            set { this._certificateOverride = value; }
        }

        // Check to see if CertificateOverride property is set
        internal bool IsSetCertificateOverride()
        {
            return this._certificateOverride != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeTypeOverride. 
        /// <para>
        /// The name of a compute type for this build that overrides the one specified in the
        /// build project.
        /// </para>
        /// </summary>
        public ComputeType ComputeTypeOverride
        {
            get { return this._computeTypeOverride; }
            set { this._computeTypeOverride = value; }
        }

        // Check to see if ComputeTypeOverride property is set
        internal bool IsSetComputeTypeOverride()
        {
            return this._computeTypeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentTypeOverride. 
        /// <para>
        /// A container type for this build that overrides the one specified in the build project.
        /// </para>
        /// </summary>
        public EnvironmentType EnvironmentTypeOverride
        {
            get { return this._environmentTypeOverride; }
            set { this._environmentTypeOverride = value; }
        }

        // Check to see if EnvironmentTypeOverride property is set
        internal bool IsSetEnvironmentTypeOverride()
        {
            return this._environmentTypeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariablesOverride. 
        /// <para>
        /// A set of environment variables that overrides, for this build only, the latest ones
        /// already defined in the build project.
        /// </para>
        /// </summary>
        public List<EnvironmentVariable> EnvironmentVariablesOverride
        {
            get { return this._environmentVariablesOverride; }
            set { this._environmentVariablesOverride = value; }
        }

        // Check to see if EnvironmentVariablesOverride property is set
        internal bool IsSetEnvironmentVariablesOverride()
        {
            return this._environmentVariablesOverride != null && this._environmentVariablesOverride.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitCloneDepthOverride. 
        /// <para>
        /// The user-defined depth of history, with a minimum value of 0, that overrides, for
        /// this build only, any previous depth of history defined in the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int GitCloneDepthOverride
        {
            get { return this._gitCloneDepthOverride.GetValueOrDefault(); }
            set { this._gitCloneDepthOverride = value; }
        }

        // Check to see if GitCloneDepthOverride property is set
        internal bool IsSetGitCloneDepthOverride()
        {
            return this._gitCloneDepthOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GitSubmodulesConfigOverride. 
        /// <para>
        ///  Information about the Git submodules configuration for this build of an AWS CodeBuild
        /// build project. 
        /// </para>
        /// </summary>
        public GitSubmodulesConfig GitSubmodulesConfigOverride
        {
            get { return this._gitSubmodulesConfigOverride; }
            set { this._gitSubmodulesConfigOverride = value; }
        }

        // Check to see if GitSubmodulesConfigOverride property is set
        internal bool IsSetGitSubmodulesConfigOverride()
        {
            return this._gitSubmodulesConfigOverride != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case sensitive identifier you provide to ensure the idempotency of the StartBuild
        /// request. The token is included in the StartBuild request and is valid for 12 hours.
        /// If you repeat the StartBuild request with the same token, but change a parameter,
        /// AWS CodeBuild returns a parameter mismatch error. 
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property ImageOverride. 
        /// <para>
        /// The name of an image for this build that overrides the one specified in the build
        /// project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ImageOverride
        {
            get { return this._imageOverride; }
            set { this._imageOverride = value; }
        }

        // Check to see if ImageOverride property is set
        internal bool IsSetImageOverride()
        {
            return this._imageOverride != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePullCredentialsTypeOverride. 
        /// <para>
        ///  The type of credentials AWS CodeBuild uses to pull images in your build. There are
        /// two valid values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CODEBUILD</code> specifies that AWS CodeBuild uses its own credentials. This
        /// requires that you modify your ECR repository policy to trust AWS CodeBuild's service
        /// principal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SERVICE_ROLE</code> specifies that AWS CodeBuild uses your build project's
        /// service role. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  When using a cross-account or private registry image, you must use SERVICE_ROLE credentials.
        /// When using an AWS CodeBuild curated image, you must use CODEBUILD credentials. 
        /// </para>
        /// </summary>
        public ImagePullCredentialsType ImagePullCredentialsTypeOverride
        {
            get { return this._imagePullCredentialsTypeOverride; }
            set { this._imagePullCredentialsTypeOverride = value; }
        }

        // Check to see if ImagePullCredentialsTypeOverride property is set
        internal bool IsSetImagePullCredentialsTypeOverride()
        {
            return this._imagePullCredentialsTypeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property InsecureSslOverride. 
        /// <para>
        /// Enable this flag to override the insecure SSL setting that is specified in the build
        /// project. The insecure SSL setting determines whether to ignore SSL warnings while
        /// connecting to the project source code. This override applies only if the build's source
        /// is GitHub Enterprise.
        /// </para>
        /// </summary>
        public bool InsecureSslOverride
        {
            get { return this._insecureSslOverride.GetValueOrDefault(); }
            set { this._insecureSslOverride = value; }
        }

        // Check to see if InsecureSslOverride property is set
        internal bool IsSetInsecureSslOverride()
        {
            return this._insecureSslOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogsConfigOverride. 
        /// <para>
        ///  Log settings for this build that override the log settings defined in the build project.
        /// 
        /// </para>
        /// </summary>
        public LogsConfig LogsConfigOverride
        {
            get { return this._logsConfigOverride; }
            set { this._logsConfigOverride = value; }
        }

        // Check to see if LogsConfigOverride property is set
        internal bool IsSetLogsConfigOverride()
        {
            return this._logsConfigOverride != null;
        }

        /// <summary>
        /// Gets and sets the property PrivilegedModeOverride. 
        /// <para>
        /// Enable this flag to override privileged mode in the build project.
        /// </para>
        /// </summary>
        public bool PrivilegedModeOverride
        {
            get { return this._privilegedModeOverride.GetValueOrDefault(); }
            set { this._privilegedModeOverride = value; }
        }

        // Check to see if PrivilegedModeOverride property is set
        internal bool IsSetPrivilegedModeOverride()
        {
            return this._privilegedModeOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the AWS CodeBuild build project to start running a build.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property QueuedTimeoutInMinutesOverride. 
        /// <para>
        ///  The number of minutes a build is allowed to be queued before it times out. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=480)]
        public int QueuedTimeoutInMinutesOverride
        {
            get { return this._queuedTimeoutInMinutesOverride.GetValueOrDefault(); }
            set { this._queuedTimeoutInMinutesOverride = value; }
        }

        // Check to see if QueuedTimeoutInMinutesOverride property is set
        internal bool IsSetQueuedTimeoutInMinutesOverride()
        {
            return this._queuedTimeoutInMinutesOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistryCredentialOverride. 
        /// <para>
        ///  The credentials for access to a private registry. 
        /// </para>
        /// </summary>
        public RegistryCredential RegistryCredentialOverride
        {
            get { return this._registryCredentialOverride; }
            set { this._registryCredentialOverride = value; }
        }

        // Check to see if RegistryCredentialOverride property is set
        internal bool IsSetRegistryCredentialOverride()
        {
            return this._registryCredentialOverride != null;
        }

        /// <summary>
        /// Gets and sets the property ReportBuildStatusOverride. 
        /// <para>
        ///  Set to true to report to your source provider the status of a build's start and completion.
        /// If you use this option with a source provider other than GitHub, GitHub Enterprise,
        /// or Bitbucket, an invalidInputException is thrown. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  The status of a build triggered by a webhook is always reported to your source provider.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public bool ReportBuildStatusOverride
        {
            get { return this._reportBuildStatusOverride.GetValueOrDefault(); }
            set { this._reportBuildStatusOverride = value; }
        }

        // Check to see if ReportBuildStatusOverride property is set
        internal bool IsSetReportBuildStatusOverride()
        {
            return this._reportBuildStatusOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryArtifactsOverride. 
        /// <para>
        ///  An array of <code>ProjectArtifacts</code> objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectArtifacts> SecondaryArtifactsOverride
        {
            get { return this._secondaryArtifactsOverride; }
            set { this._secondaryArtifactsOverride = value; }
        }

        // Check to see if SecondaryArtifactsOverride property is set
        internal bool IsSetSecondaryArtifactsOverride()
        {
            return this._secondaryArtifactsOverride != null && this._secondaryArtifactsOverride.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecondarySourcesOverride. 
        /// <para>
        ///  An array of <code>ProjectSource</code> objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectSource> SecondarySourcesOverride
        {
            get { return this._secondarySourcesOverride; }
            set { this._secondarySourcesOverride = value; }
        }

        // Check to see if SecondarySourcesOverride property is set
        internal bool IsSetSecondarySourcesOverride()
        {
            return this._secondarySourcesOverride != null && this._secondarySourcesOverride.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecondarySourcesVersionOverride. 
        /// <para>
        ///  An array of <code>ProjectSourceVersion</code> objects that specify one or more versions
        /// of the project's secondary sources to be used for this build only. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectSourceVersion> SecondarySourcesVersionOverride
        {
            get { return this._secondarySourcesVersionOverride; }
            set { this._secondarySourcesVersionOverride = value; }
        }

        // Check to see if SecondarySourcesVersionOverride property is set
        internal bool IsSetSecondarySourcesVersionOverride()
        {
            return this._secondarySourcesVersionOverride != null && this._secondarySourcesVersionOverride.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleOverride. 
        /// <para>
        /// The name of a service role for this build that overrides the one specified in the
        /// build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ServiceRoleOverride
        {
            get { return this._serviceRoleOverride; }
            set { this._serviceRoleOverride = value; }
        }

        // Check to see if ServiceRoleOverride property is set
        internal bool IsSetServiceRoleOverride()
        {
            return this._serviceRoleOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAuthOverride. 
        /// <para>
        /// An authorization type for this build that overrides the one defined in the build project.
        /// This override applies only if the build project's source is BitBucket or GitHub.
        /// </para>
        /// </summary>
        public SourceAuth SourceAuthOverride
        {
            get { return this._sourceAuthOverride; }
            set { this._sourceAuthOverride = value; }
        }

        // Check to see if SourceAuthOverride property is set
        internal bool IsSetSourceAuthOverride()
        {
            return this._sourceAuthOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocationOverride. 
        /// <para>
        /// A location that overrides, for this build, the source location for the one defined
        /// in the build project.
        /// </para>
        /// </summary>
        public string SourceLocationOverride
        {
            get { return this._sourceLocationOverride; }
            set { this._sourceLocationOverride = value; }
        }

        // Check to see if SourceLocationOverride property is set
        internal bool IsSetSourceLocationOverride()
        {
            return this._sourceLocationOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTypeOverride. 
        /// <para>
        /// A source input type, for this build, that overrides the source input defined in the
        /// build project.
        /// </para>
        /// </summary>
        public SourceType SourceTypeOverride
        {
            get { return this._sourceTypeOverride; }
            set { this._sourceTypeOverride = value; }
        }

        // Check to see if SourceTypeOverride property is set
        internal bool IsSetSourceTypeOverride()
        {
            return this._sourceTypeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// A version of the build input to be built, for this build only. If not specified, the
        /// latest version is used. If specified, must be one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For AWS CodeCommit: the commit ID to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GitHub: the commit ID, pull request ID, branch name, or tag name that corresponds
        /// to the version of the source code you want to build. If a pull request ID is specified,
        /// it must use the format <code>pr/pull-request-ID</code> (for example <code>pr/25</code>).
        /// If a branch name is specified, the branch's HEAD commit ID is used. If not specified,
        /// the default branch's HEAD commit ID is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Bitbucket: the commit ID, branch name, or tag name that corresponds to the version
        /// of the source code you want to build. If a branch name is specified, the branch's
        /// HEAD commit ID is used. If not specified, the default branch's HEAD commit ID is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Simple Storage Service (Amazon S3): the version ID of the object that represents
        /// the build input ZIP file to use.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If <code>sourceVersion</code> is specified at the project level, then this <code>sourceVersion</code>
        /// (at the build level) takes precedence. 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/sample-source-version.html">Source
        /// Version Sample with CodeBuild</a> in the <i>AWS CodeBuild User Guide</i>. 
        /// </para>
        /// </summary>
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutesOverride. 
        /// <para>
        /// The number of build timeout minutes, from 5 to 480 (8 hours), that overrides, for
        /// this build only, the latest setting already defined in the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=480)]
        public int TimeoutInMinutesOverride
        {
            get { return this._timeoutInMinutesOverride.GetValueOrDefault(); }
            set { this._timeoutInMinutesOverride = value; }
        }

        // Check to see if TimeoutInMinutesOverride property is set
        internal bool IsSetTimeoutInMinutesOverride()
        {
            return this._timeoutInMinutesOverride.HasValue; 
        }

    }
}