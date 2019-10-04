echo "Hello World! I'm a post-build script!"
echo "I run at the end of your build." 
echo "Documentation: https://docs.microsoft.com/en-us/appcenter/build/custom/scripts/#post-build"
echo "Referencing source directory: " $APPCENTER_SOURCE_DIRECTORY
echo "Contents: "
ls $APPCENTER_SOURCE_DIRECTORY
echo "& output directory: " $APPCENTER_OUTPUT_DIRECTORY
echo "Contents: "
ls $APPCENTER_OUTPUT_DIRECTORY

# End
echo "end post-build script"