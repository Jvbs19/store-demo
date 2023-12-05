public static class Currency
{
    static float m_money = 1000;

    public static void CalculateMoney(float money)
    {
        m_money += money;
    }
    public static float CheckMoney()
    {
        return m_money;
    }
}
