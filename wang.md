
lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang (master)
$ git init
Initialized empty Git repository in C:/Users/lenovo/Desktop/18wang/.git/

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang (master)
$ git clone git@github.com/cduwang/CSharp.git
fatal: repository 'git@github.com/cduwang/CSharp.git' does not exist

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang (master)
$ git clone https://github.com/cduwang/CSharp.git
Cloning into 'CSharp'...
remote: Enumerating objects: 3, done.
remote: Counting objects: 100% (3/3), done.
remote: Total 3 (delta 0), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (3/3), done.

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang (master)
$ cp README.md wang.md
cp: cannot stat 'README.md': No such file or directory

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang (master)
$ ls
CSharp/

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang (master)
$ cd CSharp

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ ls
README.md

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ cp README.md wang.md

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ git add wang.md && git commit-m wang &&.
git: 'commit-m' is not a git command. See 'git --help'.

The most similar command is
        commit-tree

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ git add wang.md && git commit-m 'wang'&&.
git: 'commit-m' is not a git command. See 'git --help'.

The most similar command is
        commit-tree

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ git add . && git commit -m 'new' && .

*** Please tell me who you are.

Run

  git config --global user.email "you@example.com"
  git config --global user.name "Your Name"

to set your account's default identity.
Omit --global to set the identity only in this repository.

fatal: unable to auto-detect email address (got 'lenovo@Lenovo-PC.(none)')

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ git config --global 306992982@qq.com
error: invalid key: 306992982@qq.com

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ git config --global user.email 306992982@qq.com

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ git add . && git commit -m 'new' && .
[master ff7e685] new
 2 files changed, 32 insertions(+), 2 deletions(-)
 rewrite README.md (100%)
 create mode 100644 wang.md
bash: .: filename argument required
.: usage: . filename [arguments]

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ git push


Logon failed, use ctrl+c to cancel basic credential prompt.
Username for 'https://github.com': remote: Anonymous access to cduwang/CSharp.git denied.
fatal: Authentication failed for 'https://github.com/cduwang/CSharp.git/'

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ git push
Counting objects: 3, done.
Delta compression using up to 4 threads.
Compressing objects: 100% (3/3), done.
Writing objects: 100% (3/3), 488 bytes | 25.00 KiB/s, done.
Total 3 (delta 0), reused 0 (delta 0)
To https://github.com/cduwang/CSharp.git
   8a1119f..ff7e685  master -> master

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$ ls
README.md  wang.md

lenovo@Lenovo-PC MINGW32 ~/Desktop/18wang/CSharp (master)
$
