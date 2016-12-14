#!/usr/bin/env bash

usage()
{
    echo
    echo "WIP."
    echo "Hello."
    echo
}

if [ "$1" == "-?" ]; then
    usage
fi

__scriptpath=$(cd "$(dirname "$0")"; pwd -P)


while :; do
    if [ $# -le 0 ]; then
        break
    fi
    
    if [[ $1 == *"centos.7"* ]] ; then
       __IsCentos=1
    fi
    
    if [[ $1 == *"osx.10"* ]] ; then
       __IsOSX=1
    fi

    lowerI="$(echo $1 | awk '{print tolower($0)}')"
    case $lowerI in
        useservergc)
            __ServerGC=1
            ;;
        *)
    __UnprocessedBuildArgs="$__UnprocessedBuildArgs $1"
    esac

    shift
done

"$__scriptpath/build-managed.sh" $__UnprocessedBuildArgs

if [ $? -ne 0 ];then
   exit 1
fi
