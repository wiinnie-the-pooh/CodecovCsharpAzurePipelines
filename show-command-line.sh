#!/bin/sh

xargs -0 printf '%s\n' < /proc/$$/cmdline
