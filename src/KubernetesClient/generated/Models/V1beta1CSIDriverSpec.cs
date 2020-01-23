// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CSIDriverSpec is the specification of a CSIDriver.
    /// </summary>
    public partial class V1beta1CSIDriverSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1CSIDriverSpec class.
        /// </summary>
        public V1beta1CSIDriverSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1CSIDriverSpec class.
        /// </summary>
        /// <param name="attachRequired">attachRequired indicates this CSI
        /// volume driver requires an attach operation (because it implements
        /// the CSI ControllerPublishVolume() method), and that the Kubernetes
        /// attach detach controller should call the attach volume interface
        /// which checks the volumeattachment status and waits until the volume
        /// is attached before proceeding to mounting. The CSI
        /// external-attacher coordinates with CSI volume driver and updates
        /// the volumeattachment status when the attach operation is complete.
        /// If the CSIDriverRegistry feature gate is enabled and the value is
        /// specified to false, the attach operation will be skipped. Otherwise
        /// the attach operation will be called.</param>
        /// <param name="podInfoOnMount">If set to true, podInfoOnMount
        /// indicates this CSI volume driver requires additional pod
        /// information (like podName, podUID, etc.) during mount operations.
        /// If set to false, pod information will not be passed on mount.
        /// Default is false. The CSI driver specifies podInfoOnMount as part
        /// of driver deployment. If true, Kubelet will pass pod information as
        /// VolumeContext in the CSI NodePublishVolume() calls. The CSI driver
        /// is responsible for parsing and validating the information passed in
        /// as VolumeContext. The following VolumeConext will be passed if
        /// podInfoOnMount is set to true. This list might grow, but the prefix
        /// will be used. "csi.storage.k8s.io/pod.name": pod.Name
        /// "csi.storage.k8s.io/pod.namespace": pod.Namespace
        /// "csi.storage.k8s.io/pod.uid": string(pod.UID)
        /// "csi.storage.k8s.io/ephemeral": "true" iff the volume is an
        /// ephemeral inline volume
        /// defined by a CSIVolumeSource, otherwise "false"
        ///
        /// "csi.storage.k8s.io/ephemeral" is a new feature in Kubernetes 1.16.
        /// It is only required for drivers which support both the "Persistent"
        /// and "Ephemeral" VolumeLifecycleMode. Other drivers can leave pod
        /// info disabled and/or ignore this field. As Kubernetes 1.15 doesn't
        /// support this field, drivers can only support one mode when deployed
        /// on such a cluster and the deployment determines which mode that is,
        /// for example via a command line parameter of the driver.</param>
        /// <param name="volumeLifecycleModes">VolumeLifecycleModes defines
        /// what kind of volumes this CSI volume driver supports. The default
        /// if the list is empty is "Persistent", which is the usage defined by
        /// the CSI specification and implemented in Kubernetes via the usual
        /// PV/PVC mechanism. The other mode is "Ephemeral". In this mode,
        /// volumes are defined inline inside the pod spec with CSIVolumeSource
        /// and their lifecycle is tied to the lifecycle of that pod. A driver
        /// has to be aware of this because it is only going to get a
        /// NodePublishVolume call for such a volume. For more information
        /// about implementing this mode, see
        /// https://kubernetes-csi.github.io/docs/ephemeral-local-volumes.html
        /// A driver can support one or more of these modes and more modes may
        /// be added in the future.</param>
        public V1beta1CSIDriverSpec(bool? attachRequired = default(bool?), bool? podInfoOnMount = default(bool?), IList<string> volumeLifecycleModes = default(IList<string>))
        {
            AttachRequired = attachRequired;
            PodInfoOnMount = podInfoOnMount;
            VolumeLifecycleModes = volumeLifecycleModes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets attachRequired indicates this CSI volume driver
        /// requires an attach operation (because it implements the CSI
        /// ControllerPublishVolume() method), and that the Kubernetes attach
        /// detach controller should call the attach volume interface which
        /// checks the volumeattachment status and waits until the volume is
        /// attached before proceeding to mounting. The CSI external-attacher
        /// coordinates with CSI volume driver and updates the volumeattachment
        /// status when the attach operation is complete. If the
        /// CSIDriverRegistry feature gate is enabled and the value is
        /// specified to false, the attach operation will be skipped. Otherwise
        /// the attach operation will be called.
        /// </summary>
        [JsonProperty(PropertyName = "attachRequired")]
        public bool? AttachRequired { get; set; }

        /// <summary>
        /// Gets or sets if set to true, podInfoOnMount indicates this CSI
        /// volume driver requires additional pod information (like podName,
        /// podUID, etc.) during mount operations. If set to false, pod
        /// information will not be passed on mount. Default is false. The CSI
        /// driver specifies podInfoOnMount as part of driver deployment. If
        /// true, Kubelet will pass pod information as VolumeContext in the CSI
        /// NodePublishVolume() calls. The CSI driver is responsible for
        /// parsing and validating the information passed in as VolumeContext.
        /// The following VolumeConext will be passed if podInfoOnMount is set
        /// to true. This list might grow, but the prefix will be used.
        /// "csi.storage.k8s.io/pod.name": pod.Name
        /// "csi.storage.k8s.io/pod.namespace": pod.Namespace
        /// "csi.storage.k8s.io/pod.uid": string(pod.UID)
        /// "csi.storage.k8s.io/ephemeral": "true" iff the volume is an
        /// ephemeral inline volume
        /// defined by a CSIVolumeSource, otherwise "false"
        ///
        /// "csi.storage.k8s.io/ephemeral" is a new feature in Kubernetes 1.16.
        /// It is only required for drivers which support both the "Persistent"
        /// and "Ephemeral" VolumeLifecycleMode. Other drivers can leave pod
        /// info disabled and/or ignore this field. As Kubernetes 1.15 doesn't
        /// support this field, drivers can only support one mode when deployed
        /// on such a cluster and the deployment determines which mode that is,
        /// for example via a command line parameter of the driver.
        /// </summary>
        [JsonProperty(PropertyName = "podInfoOnMount")]
        public bool? PodInfoOnMount { get; set; }

        /// <summary>
        /// Gets or sets volumeLifecycleModes defines what kind of volumes this
        /// CSI volume driver supports. The default if the list is empty is
        /// "Persistent", which is the usage defined by the CSI specification
        /// and implemented in Kubernetes via the usual PV/PVC mechanism. The
        /// other mode is "Ephemeral". In this mode, volumes are defined inline
        /// inside the pod spec with CSIVolumeSource and their lifecycle is
        /// tied to the lifecycle of that pod. A driver has to be aware of this
        /// because it is only going to get a NodePublishVolume call for such a
        /// volume. For more information about implementing this mode, see
        /// https://kubernetes-csi.github.io/docs/ephemeral-local-volumes.html
        /// A driver can support one or more of these modes and more modes may
        /// be added in the future.
        /// </summary>
        [JsonProperty(PropertyName = "volumeLifecycleModes")]
        public IList<string> VolumeLifecycleModes { get; set; }

    }
}