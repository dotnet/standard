#!/usr/bin/env bash

usage()
{
    echo "Usage: call ./build.sh"
    echo
}


__scriptpath=$(cd "$(dirname "$0")"; pwd -P)

$__scriptpath/run.sh build-managed 
exit $?