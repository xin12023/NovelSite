# NovelSite
小说站开发



### 数据库部分
语言使用ASP.NET CORE , ORM框架使用SqlSugar

数据库结构如下

用户表（users）：

user_id：用户ID，唯一标识一个用户
username：用户名，用户登录的用户名
password：密码，用户登录的密码
email：邮箱，用户注册时填写的邮箱
register_date：注册日期，用户注册的日期
user_status：用户状态，用户的状态，如正常、禁用等
update_time：更新时间，最近一次更新用户信息的时间
member：会员到期时间，用户会员的到期时间

阅读记录表（read_records）：

record_id：阅读记录ID，唯一标识一条阅读记录
user_id：用户ID，标识该条阅读记录属于哪个用户
novel_id：小说ID，标识该条阅读记录属于哪本小说
chapter_id：章节ID，标识该条阅读记录属于哪个章节
read_date：阅读日期，该条阅读记录的日期
read_progress：阅读进度，记录用户该条阅读记录的阅读进度

分类表（categories）：

category_id：分类ID，唯一标识一个分类
parent_id：父级ID，标识该分类的父级分类
category_name：分类名称，分类的名称
category_description：分类描述，对该分类的简要描述

小说表（novels）： 小说的目录记录

novel_id：小说ID，唯一标识一本小说
novel_name：小说名称
author_name：作者名称
category_id：分类ID，与分类表关联
cover_image：封面图片
introduction：简介
update_date：更新日期
status：状态，表示小说是连载还是已完结
recommendation_count：推荐数量，记录用户对该小说的推荐次数


章节表（chapters）：

chapter_id：章节ID，唯一标识一章节
novel_id：小说ID，标识该章节属于哪本小说
chapter_title：章节标题，该章节的标题
chapter_content：章节内容，该章节的最终显示内容
chapter_initial：章节采集入库内容，该章节采集入库的原始内容
update_date：更新日期，该章节最近一次更新的日期

评论表（comments）：

comment_id: 评论ID，唯一标识一条评论
user_id: 用户ID，标识该评论的用户
novel_id: 小说ID，标识该评论所属的小说
chapter_id: 章节ID，标识该评论所属的章节
comment_content: 评论内容，记录该评论的文本内容
comment_date: 评论日期，记录该评论的发表日期
like_count: 点赞数，记录该评论获得的点赞数量

收藏表（collections）：

collection_id：收藏ID，唯一标识一个收藏记录
user_id：用户ID，收藏者的用户ID
novel_id：小说ID，被收藏的小说ID
collection_date：收藏日期，收藏时间

订单表（orders）：

order_id：订单ID，唯一标识一个订单
user_id：用户ID，生成该订单的用户ID
order_amount：订单金额，该订单的支付金额
order_time：订单时间，订单生成时间
update_time：更新时间，订单状态更新时间

站内信表（messages）：

message_id：消息ID，唯一标识一条站内信
from_user_id：发送者ID，站内信发送者的用户ID
to_user_id：接收者ID，站内信接收者的用户ID
message_content：消息内容，站内信的具体内容
reply_content：回复内容，站内信的回复内容
send_time：发送时间，站内信的发送时间

系统设置表（settings）：

site_name：站点名称，用于显示网站的名称
static_template：静态模板，用于设置网站的模板
template_path：模板路径，用于设置模板所在的路径


Code First 代码优先的方式创建数据库







采集系统

采集系统可以有多个采集器，每个采集器负责采集一个特定来源的小说信息。每个采集器应该可以独立运行和管理。
采集系统需要有一个调度器，用于调度采集器的运行，可以根据设定的时间或触发条件进行调度。
采集系统需要有一个存储器，用于保存采集的小说信息。可以考虑使用数据库或者文件存储等方式。
采集系统需要有一个监控器，用于监控采集器和调度器的运行状态，可以及时发现和解决问题。
采集系统需要有一个管理界面，用于管理采集器、调度器、存储器和监控器等组件，以及配置采集规则、调度规则等信息。

在实现采集系统时，需要考虑以下问题：

如何处理采集到的小说信息，包括去重、更新、删除等操作。
如何处理采集过程中的异常情况，如网络中断、页面解析错误等问题。
如何保证采集器和调度器的高可用性和可靠性，避免单点故障。
如何保证采集器和调度器的性能和扩展性，支持高并发和大规模数据处理。
如何保证采集系统的安全性和数据隐私性，避免敏感信息泄露和数据损坏。




采集源表（sources）：

source_id 采集源ID，自增主键
source_name 采集源名称
source_url 采集源URL
last_crawl_time 最后一次采集时间

采集规则表（rules）：

rule_id 采集规则ID，自增主键
source_id 采集源ID，外键
rule_name 采集规则名称
html_parser HTML解析规则
data_extractor 数据提取规则
update_time 更新时间

采集数据表（data）：

data_id 数据ID，自增主键
source_id 采集源ID，外键
data_type 数据类型，如小说信息、章节信息等
data_content 数据内容
crawl_time 采集时间

采集任务表（tasks）：

task_id 任务ID，自增主键
source_id 采集源ID，外键
task_type 任务类型，如全站采集、增量采集等
task_status 任务状态，如待执行、执行中、已完成等
task_schedule 任务调度规则，如每天、每周等
last_crawl_time 最后一次采集时间
create_time 创建时间
update_time 更新时间
