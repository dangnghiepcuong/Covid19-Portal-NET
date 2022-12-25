$(document).ready(function () {

    // LOAD FRONT END DATA
    menu_title = '<a href="/MOH/ManageOrg">Quản lý đơn vị tiêm chủng</a>'
    $('#function-navigation-bar-title').html(menu_title)

    homepage = '<a href="/Home">Trang chủ</a>'
    $('#homepage-path').html(homepage)

    subpage = '<a href="/MOH/ManageOrg">Đơn vị tiêm chủng</a>'
    $('#subpage-path').html(subpage)

    selected_function = '<a href="/MOH/ManageOrg">Quản lý đơn vị tiêm chủng</a>'
    $('#selected-function-path').html(selected_function)

    $('#function-menu-title').text('Đơn vị tiêm chủng')

    menu = '<br><a href="/MOH/ManageOrg"><li>Quản lý đơn vị</li></a>'
    menu += '<br><a href="/MOH/ProvideOrgAcc"><li>Cấp tài khoản đơn vị</li></a>'

    $('#function-menu-list').find('ul').html(menu)
    // END LOAD FRONT END DATA

    LoadOrg()

    $('#btn-filter-org').click(function () {
        LoadOrg()
    })

    function LoadOrg() {
        province = $('#select-province').find('option:selected').text()
        district = $('#select-district').find('option:selected').text()
        town = $('#select-town').find('option:selected').text()

        $.ajax({
            cache: false,
            url: '/MOH/LoadOrg',
            type: 'POST',
            data: { province: province, district: district, town: town },
            success: function (result) {
                if (result.message.substring(0, 3) == 'ORA') {    //EXCEPTION
                    alert(result.message)
                    return
                }
                $('#list-org').html(result.html)
            },
            error: function (error) {
            }
        })
    }
})

