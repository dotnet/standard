#!/usr/bin/env bash

__scriptpath=$(cd "$(dirname "$0")"; pwd -P)
"$__scriptpath/build-managed.sh" $@
exit $?
