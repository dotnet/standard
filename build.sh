#!/usr/bin/env bash

usage()
{
    echo
    echo "Use this script only for generic build instructions that apply for both native builds and managed builds."
    echo
}

if [ "$1" == "-?" ]; then
    usage
fi

__scriptpath=$(cd "$(dirname "$0")"; pwd -P)

"$__scriptpath/build-managed.sh"

if [ $? -ne 0 ];then
   exit 1
fi
