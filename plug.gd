# 需安装gd-plug插件方可实现项目依赖插件一键安装管理
# gd-plug-ui可选插件，可在编辑器内使用图形化界面操作

extends "res://addons/gd-plug/plug.gd"

func _plugging():
	# Declare plugins with plug(repo, args)
	# For example, clone from github repo("user/repo_name")
	# plug("imjp94/gd-YAFSM") # By default, gd-plug will only install anything from "addons/" directory
	# Or you can explicitly specify which file/directory to include
	# plug("imjp94/gd-YAFSM", {"include": ["addons/"]}) # By default, gd-plug will only install anything from "addons/" directory
	

	#primitive_shapes
	plug("nofacer/godot-shapes",{"tag": "1.0.1"})
