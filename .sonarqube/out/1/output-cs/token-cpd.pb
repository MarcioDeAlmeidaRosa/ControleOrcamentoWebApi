Ù
|D:\GIT\ControleOrcamentoWebApi\Contextos\ControleOrcamento.Contexto.Domain\Entidade\Contratos\Usuario\UsuarioAutenticacao.cs
	namespace 	
ControleOrcamento
 
. 
Contexto $
.$ %
Domain% +
.+ ,
Entidade, 4
.4 5
	Contratos5 >
.> ?
Usuario? F
{ 
public		 

sealed		 
class		 
UsuarioAutenticacao		 +
:		, -
UsuarioBase		. 9
{

 
public 
string 
Login 
{ 
get !
;! "
private# *
set+ .
;. /
}0 1
public 
SenhaSecreta 
Senha !
{" #
get$ '
;' (
private) 0
set1 4
;4 5
}6 7
public 
string 
HashAutenticacao &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public## 
UsuarioAutenticacao## "
(##" #
string### )
login##* /
,##/ 0
SenhaSecreta##1 =
senha##> C
)##C D
{$$ 	
Login%% 
=%% 
login%% 
??%% 
throw%% "
new%%# &!
ArgumentNullException%%' <
(%%< =
nameof%%= C
(%%C D
login%%D I
)%%I J
,%%J K
$str%%L l
)%%l m
;%%m n
Senha&& 
=&& 
senha&& 
??&& 
throw&& "
new&&# &!
ArgumentNullException&&' <
(&&< =
nameof&&= C
(&&C D
senha&&D I
)&&I J
,&&J K
$str&&L a
)&&a b
;&&b c
if'' 
('' 
senha'' 
.'' 
Invalid'' 
)'' 
{(( 
throw)) 
new)) 
ArgumentException)) +
())+ ,
senha)), 1
.))1 2
Notifications))2 ?
.))? @
ToString))@ H
())H I
)))I J
,))J K
nameof))L R
())R S
senha))S X
)))X Y
)))Y Z
;))Z [
}** 
}++ 	
[00 	
Obsolete00	 
(00 
$str00 Q
)00Q R
]00R S
public11 
UsuarioAutenticacao11 "
(11" #
)11# $
{22 	
}44 	
}55 
}66 ¸
tD:\GIT\ControleOrcamentoWebApi\Contextos\ControleOrcamento.Contexto.Domain\Entidade\Contratos\Usuario\UsuarioBase.cs
	namespace 	
ControleOrcamento
 
. 
Contexto $
.$ %
Domain% +
.+ ,
Entidade, 4
.4 5
	Contratos5 >
.> ?
Usuario? F
{ 
public 

abstract 
class 
UsuarioBase %
:& '
UsuarioCandidato( 8
{		 
public 

NomePessoa 
Nome 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} »
yD:\GIT\ControleOrcamentoWebApi\Contextos\ControleOrcamento.Contexto.Domain\Entidade\Contratos\Usuario\UsuarioCandidato.cs
	namespace 	
ControleOrcamento
 
. 
Contexto $
.$ %
Domain% +
.+ ,
Entidade, 4
.4 5
	Contratos5 >
.> ?
Usuario? F
{ 
public 

abstract 
class 
UsuarioCandidato *
:+ ,
EntidadeBase- 9
{		 
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
} 
} Ô
cD:\GIT\ControleOrcamentoWebApi\Contextos\ControleOrcamento.Contexto.Domain\Entidade\EntidadeBase.cs
	namespace 	
ControleOrcamento
 
. 
Contexto $
.$ %
Domain% +
.+ ,
Entidade, 4
{ 
public		 

abstract		 
class		 
EntidadeBase		 &
:		' (

Notifiable		) 3
{

 
	protected 
EntidadeBase 
( 
)  
{ 	
Id 
= 
Guid 
. 
NewGuid 
( 
) 
;  
} 	
public 
Guid 
Id 
{ 
get 
; 
private %
set& )
;) *
}+ ,
} 
} ª	
`D:\GIT\ControleOrcamentoWebApi\Contextos\ControleOrcamento.Contexto.Domain\ObjetosValor\Email.cs
	namespace 	
ControleOrcamento
 
. 
Contexto $
.$ %
Domain% +
.+ ,
ObjetosValor, 8
{ 
public 

sealed 
class 
Email 
: 
ObjetoValor  +
{		 
public 
string 
Endereco 
{  
get! $
;$ %
private& -
set. 1
;1 2
}3 4
public 
Email 
( 
string 
endereco $
)$ %
{ 	
Endereco 
= 
endereco 
;  
AddNotifications 
( 
new  
Contract! )
() *
)* +
. 
Requires 
( 
) 
. 
IsEmail 
( 
Endereco !
,! "
$str# 3
,3 4
$str5 F
)F G
) 
; 
} 	
} 
} ®
eD:\GIT\ControleOrcamentoWebApi\Contextos\ControleOrcamento.Contexto.Domain\ObjetosValor\NomePessoa.cs
	namespace 	
ControleOrcamento
 
. 
Contexto $
.$ %
Domain% +
.+ ,
ObjetosValor, 8
{ 
public 

sealed 
class 

NomePessoa "
:# $
ObjetoValor% 0
{		 
public 
string 
Nome 
{ 
get  
;  !
private" )
set* -
;- .
}/ 0
public 
string 
	SobreNome 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public 

NomePessoa 
( 
string  
nome! %
,% &
string' -
	sobrenome. 7
)7 8
{ 	
Nome 
= 
nome 
; 
	SobreNome 
= 
	sobrenome !
;! "
AddNotifications 
( 
new  
Contract! )
() *
)* +
. 
Requires 
( 
) 
. 
	HasMinLen 
( 
Nome 
,  
$num! "
," #
$str$ 5
,5 6
$str7 a
)a b
.   
	HasMinLen   
(   
	SobreNome   $
,  $ %
$num  & '
,  ' (
$str  ) ?
,  ? @
$str  A p
)  p q
.!! 
	HasMaxLen!! 
(!! 
Nome!! 
,!!  
$num!!! #
,!!# $
$str!!% 6
,!!6 7
$str!!8 \
)!!\ ]
)"" 
;"" 
}## 	
public)) 
override)) 
string)) 
ToString)) '
())' (
)))( )
{** 	
return++ 
$"++ 
{++ 
Nome++ 
}++ 
{++ 
	SobreNome++ &
}++& '
"++' (
;++( )
},, 	
}-- 
}.. Â
fD:\GIT\ControleOrcamentoWebApi\Contextos\ControleOrcamento.Contexto.Domain\ObjetosValor\ObjetoValor.cs
	namespace 	
ControleOrcamento
 
. 
Contexto $
.$ %
Domain% +
.+ ,
ObjetosValor, 8
{ 
public 

abstract 
class 
ObjetoValor %
:& '

Notifiable( 2
{		 
}

 
} ²
gD:\GIT\ControleOrcamentoWebApi\Contextos\ControleOrcamento.Contexto.Domain\ObjetosValor\SenhaSecreta.cs
	namespace 	
ControleOrcamento
 
. 
Contexto $
.$ %
Domain% +
.+ ,
ObjetosValor, 8
{ 
public 

sealed 
class 
SenhaSecreta $
:% &
ObjetoValor' 2
{		 
public 
string 
Senha 
{ 
get !
;! "
set# &
;& '
}( )
public 
SenhaSecreta 
( 
string "
senha# (
)( )
{ 	
Senha 
= 
senha 
; 
AddNotifications 
( 
new  
Contract! )
() *
)* +
. 
Requires 
( 
) 
. 
	HasMinLen 
( 
Senha  
,  !
$num" #
,# $
$str% 9
,9 :
$str; g
)g h
. 
	HasMaxLen 
( 
Senha  
,  !
$num" $
,$ %
$str& :
,: ;
$str< i
)i j
. 
Matchs 
( 
Senha 
, 
$str G
,G H
$strI ]
,] ^
$str	_ «
)
« ¬
) 
; 
} 	
} 
} 